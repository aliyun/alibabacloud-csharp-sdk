// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateUdfRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateUdfRequestCreateCommand CreateCommand { get; set; }
        public class CreateUdfRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The category identifier of the user-defined function (UDF). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: window function</description></item>
            /// <item><description>2: statistical function</description></item>
            /// <item><description>3: numerical function</description></item>
            /// <item><description>4: string function</description></item>
            /// <item><description>5: time function</description></item>
            /// <item><description>6: IP address helper function</description></item>
            /// <item><description>7: URL-related function</description></item>
            /// <item><description>8: encoding and decoding function</description></item>
            /// <item><description>9: business-related function</description></item>
            /// <item><description>10: other</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The name of the class that implements the function in the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.lydaas.SleepTest</para>
            /// </summary>
            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <para>The command format for function invocation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>udf_sleep(100)</para>
            /// </summary>
            [NameInMap("CommandHelp")]
            [Validation(Required=false)]
            public string CommandHelp { get; set; }

            /// <summary>
            /// <para>The submission comment.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The compute engine type. Valid values: MAX_COMPUTE and HADOOP.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("ComputeEngineType")]
            [Validation(Required=false)]
            public string ComputeEngineType { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The storage directory. Default value: /.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public string Directory { get; set; }

            /// <summary>
            /// <para>The function name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_udf</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>711833</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The IDs of the referenced resources.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RefResourceIdList")]
            [Validation(Required=false)]
            public List<long?> RefResourceIdList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
