// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the ECS instances in the cluster.</para>
        /// </summary>
        [NameInMap("ClusterMemberPage")]
        [Validation(Required=false)]
        public ListClusterMembersResponseBodyClusterMemberPage ClusterMemberPage { get; set; }
        public class ListClusterMembersResponseBodyClusterMemberPage : TeaModel {
            /// <summary>
            /// <para>The list of ECS instances in the cluster.</para>
            /// </summary>
            [NameInMap("ClusterMemberList")]
            [Validation(Required=false)]
            public ListClusterMembersResponseBodyClusterMemberPageClusterMemberList ClusterMemberList { get; set; }
            public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberList : TeaModel {
                [NameInMap("ClusterMember")]
                [Validation(Required=false)]
                public List<ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember> ClusterMember { get; set; }
                public class ListClusterMembersResponseBodyClusterMemberPageClusterMemberListClusterMember : TeaModel {
                    /// <summary>
                    /// <para>The ID of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>52984524-6d48-4bbd-85f2-a34b0e5b****</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <para>The ID of the ECS instance in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>adb03eeb-3adf-4d7e-afe1-03d1ad45****</para>
                    /// </summary>
                    [NameInMap("ClusterMemberId")]
                    [Validation(Required=false)]
                    public string ClusterMemberId { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the ECS instance was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573281038175</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The ID of the ECS instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-2zej4i2jdf3ntwhj****</para>
                    /// </summary>
                    [NameInMap("EcsId")]
                    [Validation(Required=false)]
                    public string EcsId { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the elastic compute unit (ECU). You can run the <c>dmidecode</c> command on the ECS instance to query the ECU ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70ed3f59-b476-49aa-be09-9e6c375d****</para>
                    /// </summary>
                    [NameInMap("EcuId")]
                    [Validation(Required=false)]
                    public string EcuId { get; set; }

                    /// <summary>
                    /// <para>The private IP address for the ECS instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.16.XX.XX</para>
                    /// </summary>
                    [NameInMap("PrivateIp")]
                    [Validation(Required=false)]
                    public string PrivateIp { get; set; }

                    /// <summary>
                    /// <para>The state of the ECS instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>1: The instance is running.</description></item>
                    /// <item><description>0: The instance is being converted.</description></item>
                    /// <item><description>\-1: The instance fails to be converted.</description></item>
                    /// <item><description>\-2: The instance is offline.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the ECS instance was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1573281041113</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The page number of the returned page. If this parameter is not returned, the first page is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of ECS instances returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages returned when all ECS instances are returned based on the specified PageSize parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b197-40ab-9155-****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
