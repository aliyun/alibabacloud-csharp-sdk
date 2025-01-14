// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListResourceGroupsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListResourceGroupsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("ResourceGroupList")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyPagingInfoResourceGroupList> ResourceGroupList { get; set; }
            public class ListResourceGroupsResponseBodyPagingInfoResourceGroupList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-aek2kqofrgXXXXX</para>
                /// </summary>
                [NameInMap("AliyunResourceGroupId")]
                [Validation(Required=false)]
                public string AliyunResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1727055811000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11075500042XXXXX</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-m2et4f3oc8msfbccXXXXX</para>
                /// </summary>
                [NameInMap("DefaultVpcId")]
                [Validation(Required=false)]
                public string DefaultVpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-uf8usrhs7hjd9amsXXXXX</para>
                /// </summary>
                [NameInMap("DefaultVswicthId")]
                [Validation(Required=false)]
                public string DefaultVswicthId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Serverless_res_group_524257424564736_6831777003XXXXX</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>common_resource_group</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>c442b330-3b10-4584-959e-736e4edXXXXX</para>
                /// </summary>
                [NameInMap("OrderInstanceId")]
                [Validation(Required=false)]
                public string OrderInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>创建用于普通任务的通用资源组</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CommonV2</para>
                /// </summary>
                [NameInMap("ResourceGroupType")]
                [Validation(Required=false)]
                public string ResourceGroupType { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public ListResourceGroupsResponseBodyPagingInfoResourceGroupListSpec Spec { get; set; }
                public class ListResourceGroupsResponseBodyPagingInfoResourceGroupListSpec : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public int? Amount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2CU</para>
                    /// </summary>
                    [NameInMap("Standard")]
                    [Validation(Required=false)]
                    public string Standard { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6A6CBE87-9F91-1323-B680-E7A7065XXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
