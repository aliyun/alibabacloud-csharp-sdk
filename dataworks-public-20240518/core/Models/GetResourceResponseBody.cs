// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E871F6C0-2EFF-5790-A00D-C57543EEXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>File resource details</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public GetResourceResponseBodyResource Resource { get; set; }
        public class GetResourceResponseBodyResource : TeaModel {
            /// <summary>
            /// <para>The time when the file resource was created. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700539206000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The unique identifier of the file resource.</para>
            /// <remarks>
            /// <para> This field is of type Long in SDK versions prior to 8.0.0, and of type String in SDK version 8.0.0 and later. This change does not affect the normal use of the SDK; parameters are still returned according to the type defined in the SDK. Compilation failures due to the type change may occur only when upgrading the SDK across version 8.0.0, in which case users need to manually correct the data type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>860438872620113XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the file resource was last modified. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700539206000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the file resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OpenAPI_Test_Resource. py</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner of the file resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110755000425XXXX</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the file resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The FlowSpec field information about the file resource. For more information, see <a href="https://github.com/aliyun/alibabacloud-dataworks-tool-dflow">FlowSpec</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;version&quot;: &quot;1.1.0&quot;,
            ///     &quot;kind&quot;: &quot;Resource&quot;,
            ///     &quot;spec&quot;: {
            ///         &quot;fileResources&quot;: [
            ///             {
            ///                 &quot;name&quot;: &quot;OpenAPI_Test_Resource.py&quot;,
            ///                 &quot;id&quot;: &quot;631478864897630XXXX&quot;,
            ///                 &quot;script&quot;: {
            ///                     &quot;content&quot;: &quot;&quot;,
            ///                     &quot;path&quot;: &quot;XX/OpenAPI_Test/Resource_Test/OpenAPI_Test_Resource.py&quot;,
            ///                     &quot;runtime&quot;: {
            ///                         &quot;command&quot;: &quot;ODPS_PYTHON&quot;
            ///                     }
            ///                 },
            ///                 &quot;type&quot;: &quot;python&quot;,
            ///                 &quot;file&quot;: {
            ///                     &quot;storage&quot;: {}
            ///                 },
            ///                 &quot;datasource&quot;: {
            ///                     &quot;name&quot;: &quot;odps_first&quot;,
            ///                     &quot;type&quot;: &quot;odps&quot;
            ///                 },
            ///                 &quot;metadata&quot;: {
            ///                     &quot;owner&quot;: &quot;110755000425XXXX&quot;
            ///                 }
            ///             }
            ///         ]
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

    }

}
