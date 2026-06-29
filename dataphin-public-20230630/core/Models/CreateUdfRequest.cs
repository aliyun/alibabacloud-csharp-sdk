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
            /// <para>The UDF category identifier. Valid values: 1: window function. 2: statistical function. 3: numerical function. 4: string function. 5: time function. 6: IP address utility function. 7: URL-related function. 8: encoding and decoding function. 9: business-related function. 10: other.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            /// <summary>
            /// <para>The class name that implements the function in the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.lydaas.SleepTest</para>
            /// </summary>
            [NameInMap("ClassName")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <para>The command format for function calling invoke.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>udf_sleep(100)</para>
            /// </summary>
            [NameInMap("CommandHelp")]
            [Validation(Required=false)]
            public string CommandHelp { get; set; }

            /// <summary>
            /// <para>The commit remarks.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The compute engine type. Valid values: MAX_COMPUTE, HADOOP.</para>
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
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory in which the function is stored.</para>
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
            /// <para>The IDs of referenced resources.</para>
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

    }

}
