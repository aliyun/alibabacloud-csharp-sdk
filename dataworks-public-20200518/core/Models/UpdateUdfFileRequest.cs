// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateUdfFileRequest : TeaModel {
        /// <summary>
        /// <para>The name of the class where the function is defined, which corresponds to the Class Name field in the Create Function form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibaba.DataWorks.api.udf.StringConcat</para>
        /// </summary>
        [NameInMap("ClassName")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The command format for calling the function, which corresponds to the Command Format field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(String... substrs)</para>
        /// </summary>
        [NameInMap("CmdDescription")]
        [Validation(Required=false)]
        public string CmdDescription { get; set; }

        /// <summary>
        /// <para>The example of calling the function, which corresponds to the Example field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StringConcat(\&quot;a\&quot;, \&quot;b\&quot;, \&quot;c\&quot;)</para>
        /// </summary>
        [NameInMap("Example")]
        [Validation(Required=false)]
        public string Example { get; set; }

        /// <summary>
        /// <para>The path of the folder where the function file is stored.</para>
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
        /// <para>1000000112</para>
        /// </summary>
        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The categorization of the function, which corresponds to the udf type field in the Create Function form. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MATH: mathematical operation function.</description></item>
        /// <item><description>AGGREGATE: aggregate functions.</description></item>
        /// <item><description>STRING: character string processing function.</description></item>
        /// <item><description>DATE: date processing function.</description></item>
        /// <item><description>ANALYTIC: window function.</description></item>
        /// <item><description>OTHER: other function.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STRING</para>
        /// </summary>
        [NameInMap("FunctionType")]
        [Validation(Required=false)]
        public string FunctionType { get; set; }

        /// <summary>
        /// <para>The description of the function input parameters, which corresponds to the metric description field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>List of strings to be connected</para>
        /// </summary>
        [NameInMap("ParameterDescription")]
        [Validation(Required=false)]
        public string ParameterDescription { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can click the small wrench icon in the upper-right corner of the page to go to the storage management page and view the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the English identifier displayed in the workspace switcher at the top of the DataStudio page.</para>
        /// <para>You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The list of resource names referenced by the function, separated by commas (,). This corresponds to the resources field in the Create Function form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string-concat-1.0.0.jar,commons-lang-2.6.jar</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// <para>The description of the function return value, which corresponds to the Return Value field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>New strings generated by concatenating all strings before and after the input order</para>
        /// </summary>
        [NameInMap("ReturnValue")]
        [Validation(Required=false)]
        public string ReturnValue { get; set; }

        /// <summary>
        /// <para>The description of the function purpose, which corresponds to the Description field in the Create Function form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Concatenate several strings to generate a new string</para>
        /// </summary>
        [NameInMap("UdfDescription")]
        [Validation(Required=false)]
        public string UdfDescription { get; set; }

    }

}
