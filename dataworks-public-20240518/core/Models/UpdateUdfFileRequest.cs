// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateUdfFileRequest : TeaModel {
        /// <summary>
        /// <para>The name of the class where the function is defined, which corresponds to the class name in the create function form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.DataWorks.api.udf.StringConcat</para>
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The command format used to call the function, which corresponds to the command format in the create function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(String... substrs)</para>
        /// </summary>
        [NameInMap("CmdDescription")]
        [Validation(Required=false)]
        public string CmdDescription { get; set; }

        /// <summary>
        /// <para>The call example of the function, which corresponds to the example in the create function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(\&quot;a\&quot;, \&quot;b\&quot;, \&quot;c\&quot;)</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string Example { get; set; }

        /// <summary>
        /// <para>The path of the folder where the function file is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/function/string_processing_function</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The ID of the file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The category of the function, which corresponds to the function type in the create function form. Valid values: MATH (mathematical operation functions), AGGREGATE (aggregate functions), STRING (string processing functions), DATE (date processing functions), ANALYTIC (window functions), and OTHER (other functions).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The description of the input parameters for the function, which corresponds to the parameter description in the create function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>List of strings to be connected</para>
        /// </summary>
        [NameInMap("ParameterDescription")]
        [Validation(Required=false)]
        public string ParameterDescription { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can view the ID on the Workspace Management page by clicking the Settings icon in the upper-right corner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the English identifier displayed when you switch workspaces at the top of the Data Studio page.</para>
        /// <para>You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace for the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The list of resource names referenced by the function. Separate multiple resource names with commas (,). This corresponds to the resources in the create function form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string-concat-1.0.0.jar,commons-lang-2.6.jar</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The description of the return value of the function, which corresponds to the return value in the create function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New strings generated by concatenating all strings before and after the input order</para>
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public string ReturnValue { get; set; }

        /// <summary>
        /// <para>The description of the function purpose, which corresponds to the description in the create function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Concatenate several strings to generate a new string</para>
        /// </summary>
        [NameInMap("UdfDescription")]
        [Validation(Required=false)]
        public string UdfDescription { get; set; }

    }

}
