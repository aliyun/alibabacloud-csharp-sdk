// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>A list of applicable operations.</para>
            /// </summary>
            [NameInMap("ApplicableOperations")]
            [Validation(Required=false)]
            public List<string> ApplicableOperations { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent calls.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public long? Concurrency { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1658202465000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试的实例</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc437bba-5a25-4bbc-b4c2-f268864bebb5</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582266750353</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The user who last modified the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试实例</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameters of the NLU service in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentId&quot;:&quot;1213503&quot;,&quot;isCCCAgent&quot;:&quot;true&quot;,&quot;agentKey&quot;:&quot;107e04a7519243eb83c9b549ea3b6829_p_ccc_public&quot;}</para>
            /// </summary>
            [NameInMap("NluServiceParamsJson")]
            [Validation(Required=false)]
            public string NluServiceParamsJson { get; set; }

            /// <summary>
            /// <para>The list of inbound numbers.</para>
            /// </summary>
            [NameInMap("Numbers")]
            [Validation(Required=false)]
            public List<string> Numbers { get; set; }

            /// <summary>
            /// <para>The status of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Published</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The instance ID from the source system.</para>
            /// <remarks>
            /// <para>If UnionSource is CCC, this parameter indicates the instance ID of the Cloud Communication Center instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>zhyl</para>
            /// </summary>
            [NameInMap("UnionInstanceId")]
            [Validation(Required=false)]
            public string UnionInstanceId { get; set; }

            /// <summary>
            /// <para>The source of the instance.</para>
            /// <list type="bullet">
            /// <item><description><c>CCC</c>: Cloud Communication Center</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CCC</para>
            /// </summary>
            [NameInMap("UnionSource")]
            [Validation(Required=false)]
            public string UnionSource { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8AED3C8-F57B-5D71-9A34-4A170287533F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
