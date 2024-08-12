using DefinitionOfTriangle.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionOfTriangle.App
{
    public interface IDefinitionOfTriangleService
    {
        DefinitionOfTriangleResult DetermineTriangleType(DefinitionOfTriangleRequest request);
    }
}
