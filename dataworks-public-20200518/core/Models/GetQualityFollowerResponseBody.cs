// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetQualityFollowerResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the subscription relationship.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityFollowerResponseBodyData> Data { get; set; }
        public class GetQualityFollowerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alert mode. The value is as follows:</para>
            /// <list type="bullet">
            /// <item><description>1 (Mail)</description></item>
            /// <item><description>2 (email and SMS)</description></item>
            /// <item><description>4 (DingTalk groups of robots or hook)</description></item>
            /// <item><description>5 (DingTalk groups of robots @ ALL)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AlarmMode")]
            [Validation(Required=false)]
            public int? AlarmMode { get; set; }

            /// <summary>
            /// <para>The time when the data quality rule subscription configuration was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1541576644000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>The subscriber to receive alert information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("Follower")]
            [Validation(Required=false)]
            public string Follower { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account name of the subscriber.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("FollowerAccountName")]
            [Validation(Required=false)]
            public string FollowerAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the subscription relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The update time of the data quality rule subscription configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1541576644000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the engine or data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The name of the partitioned table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dual</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You have no permission.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>38cbdef0-f6cf-49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
