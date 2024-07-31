// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateUdfFileRequest : TeaModel {
        /// <summary>
        /// The name of the class in which the function is defined. This parameter corresponds to the Class Name parameter in the Register Function section of the configuration tab of the function in the DataWorks console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// The syntax used for calling the function. This parameter corresponds to the Expression Syntax parameter in the Register Function section of the configuration tab of the function in the DataWorks console.
        /// </summary>
        [NameInMap("CmdDescription")]
        [Validation(Required=false)]
        public string CmdDescription { get; set; }

        [NameInMap("CreateFolderIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateFolderIfNotExists { get; set; }

        /// <summary>
        /// The example for calling the function. This parameter corresponds to the Example parameter in the Register Function section of the configuration tab of the function in the DataWorks console.
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string Example { get; set; }

        /// <summary>
        /// The path of the folder in which the file for the function is stored.
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// The name of the file for the function.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// The type of the function. Valid values: MATH, AGGREGATE, STRING, DATE, ANALYTIC, and OTHER. This parameter corresponds to the Function Type parameter in the Register Function section of the configuration tab of the function on the DataStudio page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// The description of the input parameters of the function. This parameter corresponds to the Parameter Description parameter in the Register Function section of the configuration tab of the function on the DataStudio page.
        /// </summary>
        [NameInMap("ParameterDescription")]
        [Validation(Required=false)]
        public string ParameterDescription { get; set; }

        /// <summary>
        /// The ID of the DataWorks workspace. You can click the Workspace Manage icon in the upper-right corner of the DataStudio page to go to the Workspace Management page and view the workspace ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The unique identifier of the DataWorks workspace. You can click the identifier in the upper-left corner of the DataStudio page to switch to another workspace.
        /// 
        /// You must specify either this parameter or the projectId parameter to determine the DataWorks workspace to which the operation is called.
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// The names of the resources that are referenced by the function. This parameter corresponds to the Resources parameter in the Register Function section of the configuration tab of the function in the DataWorks console. Multiple resource names are separated by commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// The description of the return value of the function. This parameter corresponds to the Return Value parameter in the Register Function section of the configuration tab of the function on the DataStudio page.
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public string ReturnValue { get; set; }

        /// <summary>
        /// The description of the function. This parameter corresponds to the Description parameter in the Register Function section of the configuration tab of the function in the DataWorks console.
        /// </summary>
        [NameInMap("UdfDescription")]
        [Validation(Required=false)]
        public string UdfDescription { get; set; }

    }

}
