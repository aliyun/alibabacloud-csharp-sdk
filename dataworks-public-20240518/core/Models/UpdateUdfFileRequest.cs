// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateUdfFileRequest : TeaModel {
        /// <summary>
        /// <para>The class name where the function is defined, corresponding to the class name field in the Create Function form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.DataWorks.api.udf.StringConcat</para>
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The command format for invoking the function, corresponding to the command format field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(String... substrs)</para>
        /// </summary>
        [NameInMap("CmdDescription")]
        [Validation(Required=false)]
        public string CmdDescription { get; set; }

        /// <summary>
        /// <para>An example demonstrating how to call the function, corresponding to the example field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(\&quot;a\&quot;, \&quot;b\&quot;, \&quot;c\&quot;)</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string Example { get; set; }

        /// <summary>
        /// <para>The path to the folder containing the function file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business_process/First_Business_Process/function/string_processing_function</para>
        /// </summary>
        [NameInMap("FileFolderPath")]
        [Validation(Required=false)]
        public string FileFolderPath { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The function category, corresponding to the function type field in the Create Function form. Valid values: MATH (mathematical functions), AGGREGATE (aggregate functions), STRING (string processing functions), DATE (date processing functions), ANALYTIC (window functions), and OTHER (other functions).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The function parameter description, corresponding to the parameter description field in the Create Function form.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_ALLOWD</description></item>
        /// <item><description>FAILURE_ALLOWED</description></item>
        /// <item><description>ALL_DENIED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>List of strings to be connected</para>
        /// </summary>
        [NameInMap("ParameterDescription")]
        [Validation(Required=false)]
        public string ParameterDescription { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. To find this, click the wrench icon in the upper-right corner and navigate to the workspace management page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the identifier at the top of the Data Studio page where you switch workspaces.</para>
        /// <para>Either this parameter or ProjectId must be specified to identify the target DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>A comma-separated list of resource names referenced by the function, corresponding to the resource list field in the Create Function form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string-concat-1.0.0.jar,commons-lang-2.6.jar</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The return value description, corresponding to the return value field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New strings generated by concatenating all strings before and after the input order</para>
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public string ReturnValue { get; set; }

        /// <summary>
        /// <para>The function purpose description, corresponding to the description field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Concatenate several strings to generate a new string</para>
        /// </summary>
        [NameInMap("UdfDescription")]
        [Validation(Required=false)]
        public string UdfDescription { get; set; }

    }

}
