// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDataStreamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response headers.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListDataStreamsResponseBodyHeaders Headers { get; set; }
        public class ListDataStreamsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of data streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("X-Managed-Count")]
            [Validation(Required=false)]
            public int? XManagedCount { get; set; }

            /// <summary>
            /// <para>The total storage size of indexes. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>143993923932990</para>
            /// </summary>
            [NameInMap("X-Managed-StorageSize")]
            [Validation(Required=false)]
            public long? XManagedStorageSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F99407AB-2FA9-489E-A259-40CF6DCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the returned data streams.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListDataStreamsResponseBodyResult> Result { get; set; }
        public class ListDataStreamsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The data stream status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Green: healthy.</para>
            /// </description></item>
            /// <item><description><para>Yellow: warning.</para>
            /// </description></item>
            /// <item><description><para>Red: abnormal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Green</para>
            /// </summary>
            [NameInMap("health")]
            [Validation(Required=false)]
            public string Health { get; set; }

            /// <summary>
            /// <para>The index lifecycle policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rollver1</para>
            /// </summary>
            [NameInMap("ilmPolicyName")]
            [Validation(Required=false)]
            public string IlmPolicyName { get; set; }

            /// <summary>
            /// <para>The index template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template1</para>
            /// </summary>
            [NameInMap("indexTemplateName")]
            [Validation(Required=false)]
            public string IndexTemplateName { get; set; }

            /// <summary>
            /// <para>The index information under the current data stream.</para>
            /// </summary>
            [NameInMap("indices")]
            [Validation(Required=false)]
            public List<ListDataStreamsResponseBodyResultIndices> Indices { get; set; }
            public class ListDataStreamsResponseBodyResultIndices : TeaModel {
                /// <summary>
                /// <para>The time when the data stream list was queried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-07-13T03:58:07.253Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The index status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Green: healthy.</para>
                /// </description></item>
                /// <item><description><para>Yellow: warning.</para>
                /// </description></item>
                /// <item><description><para>Red: abnormal.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Green</para>
                /// </summary>
                [NameInMap("health")]
                [Validation(Required=false)]
                public string Health { get; set; }

                /// <summary>
                /// <para>This field is deprecated and can be ignored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

                /// <summary>
                /// <para>The managed status of the index. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>following: managed.</para>
                /// </description></item>
                /// <item><description><para>closing: being unmanaged.</para>
                /// </description></item>
                /// <item><description><para>closed: not managed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>following</para>
                /// </summary>
                [NameInMap("managedStatus")]
                [Validation(Required=false)]
                public string ManagedStatus { get; set; }

                /// <summary>
                /// <para>The data stream name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Log1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The total storage space occupied by the current index. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15393899</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

            }

            /// <summary>
            /// <para>The total storage space occupied by managed indexes under the current data stream. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788239393298</para>
            /// </summary>
            [NameInMap("managedStorageSize")]
            [Validation(Required=false)]
            public long? ManagedStorageSize { get; set; }

            /// <summary>
            /// <para>The index name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-index-0001</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The total storage space occupied by all indexes under the current data stream. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788239393298</para>
            /// </summary>
            [NameInMap("totalStorageSize")]
            [Validation(Required=false)]
            public long? TotalStorageSize { get; set; }

        }

    }

}
