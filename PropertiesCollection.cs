﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject1
{

    enum eElementType
    {
        Id,
        Name,
        LinkText,
        CSSName,
        ClassName,
        XPath
    }

    class PropertiesCollection
    {
        
        public static IWebDriver driver { get; set; }
    }
}