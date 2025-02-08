// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateUdfFileRequest : TeaModel {
        /// <summary>
        /// <para>The name of the class in which the function is defined. This parameter corresponds to the Class Name parameter in the Register Function section of the configuration tab of the function in the DataWorks console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.DataWorks.api.udf.StringConcat</para>
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The syntax used for calling the function. This parameter corresponds to the Expression Syntax parameter in the Register Function section of the configuration tab of the function in the DataWorks console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(String... substrs)</para>
        /// </summary>
        [NameInMap("CmdDescription")]
        [Validation(Required=false)]
        public string CmdDescription { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create the directory that is specified by the FileFolderPath parameter if the directory does not exist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The system automatically creates the directory if the directory does not exist.</description></item>
        /// <item><description>false: The system does not automatically create the directory if the directory does not exist. In this case, the call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateFolderIfNotExists")]
        [Validation(Required=false)]
        public bool? CreateFolderIfNotExists { get; set; }

        /// <summary>
        /// <para>The example for calling the function. This parameter corresponds to the Example parameter in the Register Function section of the configuration tab of the function in the DataWorks console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(\&quot;a\&quot;, \&quot;b\&quot;, \&quot;c\&quot;)</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string Example { get; set; }

        /// <summary>
        /// <para>The path of the folder in which the file for the function is stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/function/string_processing</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The name of the file for the function.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The type of the function. Valid values: MATH, AGGREGATE, STRING, DATE, ANALYTIC, and OTHER. This parameter corresponds to the Function Type parameter in the Register Function section of the configuration tab of the function on the DataStudio page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The description of the input parameters of the function. This parameter corresponds to the Parameter Description parameter in the Register Function section of the configuration tab of the function on the DataStudio page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>List of strings to be connected</para>
        /// </summary>
        [NameInMap("ParameterDescription")]
        [Validation(Required=false)]
        public string ParameterDescription { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can click the Workspace Manage icon in the upper-right corner of the DataStudio page to go to the Workspace Management page and view the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace. You can click the identifier in the upper-left corner of the DataStudio page to switch to another workspace.</para>
        /// <para>You must specify either this parameter or the projectId parameter to determine the DataWorks workspace to which the operation is called.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The names of the resources that are referenced by the function. This parameter corresponds to the Resources parameter in the Register Function section of the configuration tab of the function in the DataWorks console. Multiple resource names are separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string-concat-1.0.0.jar,commons-lang-2.6.jar</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The description of the return value of the function. This parameter corresponds to the Return Value parameter in the Register Function section of the configuration tab of the function on the DataStudio page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New strings generated by concatenating all strings before and after the input order</para>
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public string ReturnValue { get; set; }

        /// <summary>
        /// <para>The description of the function. This parameter corresponds to the Description parameter in the Register Function section of the configuration tab of the function on the DataStudio page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Concatenate several strings to generate a new string</para>
        /// </summary>
        [NameInMap("UdfDescription")]
        [Validation(Required=false)]
        public string UdfDescription { get; set; }

    }

}
