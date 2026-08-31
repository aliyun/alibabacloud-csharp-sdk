// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAssetAttributesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAssetAttributesResponseBodyData Data { get; set; }
        public class GetAssetAttributesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of asset properties.</para>
            /// </summary>
            [NameInMap("AssetAttributeList")]
            [Validation(Required=false)]
            public List<GetAssetAttributesResponseBodyDataAssetAttributeList> AssetAttributeList { get; set; }
            public class GetAssetAttributesResponseBodyDataAssetAttributeList : TeaModel {
                /// <summary>
                /// <para>The asset name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table_orders</para>
                /// </summary>
                [NameInMap("AssetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                /// <summary>
                /// <para>The asset type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TABLE</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <para>The list of property values.</para>
                /// </summary>
                [NameInMap("AttributeList")]
                [Validation(Required=false)]
                public List<GetAssetAttributesResponseBodyDataAssetAttributeListAttributeList> AttributeList { get; set; }
                public class GetAssetAttributesResponseBodyDataAssetAttributeListAttributeList : TeaModel {
                    /// <summary>
                    /// <para>The property code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data_level</para>
                    /// </summary>
                    [NameInMap("AttributeCode")]
                    [Validation(Required=false)]
                    public string AttributeCode { get; set; }

                    /// <summary>
                    /// <para>The display name of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Data Level</para>
                    /// </summary>
                    [NameInMap("AttributeName")]
                    [Validation(Required=false)]
                    public string AttributeName { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the property is required.</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>The list of property values.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The unique identifier of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.project_a.table_orders</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The last modified time, in the format of yyyy-MM-dd HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-06-01 10:30:00</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
