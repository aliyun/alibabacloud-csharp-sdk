// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateUdfRequest : TeaModel {
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
        /// <para>The ID of the user who performs the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The update command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateUdfRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateUdfRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Window function.</description></item>
            /// <item><description>2: Aggregate function.</description></item>
            /// <item><description>3: Numerical function.</description></item>
            /// <item><description>4: String function.</description></item>
            /// <item><description>5: Time function.</description></item>
            /// <item><description>6: IP address helper function.</description></item>
            /// <item><description>7: URL-related function.</description></item>
            /// <item><description>8: Encoding and decoding function.</description></item>
            /// <item><description>9: Business-related function.</description></item>
            /// <item><description>10: Other.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
            /// <para>The ID of the custom function.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The ID of the project.</para>
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

    }

}
