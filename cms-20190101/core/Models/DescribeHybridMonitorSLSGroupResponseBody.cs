// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorSLSGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>A value of 200 indicates success.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of Logstore groups.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorSLSGroupResponseBodyList> List { get; set; }
        public class DescribeHybridMonitorSLSGroupResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The timestamp when the Logstore group was created.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652845630000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The configuration information of the Logstore group.</para>
            /// </summary>
            [NameInMap("SLSGroupConfig")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig> SLSGroupConfig { get; set; }
            public class DescribeHybridMonitorSLSGroupResponseBodyListSLSGroupConfig : TeaModel {
                /// <summary>
                /// <para>The Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Logstore-aliyun-all</para>
                /// </summary>
                [NameInMap("SLSLogstore")]
                [Validation(Required=false)]
                public string SLSLogstore { get; set; }

                /// <summary>
                /// <para>The Simple Log Service project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun-project</para>
                /// </summary>
                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("SLSRegion")]
                [Validation(Required=false)]
                public string SLSRegion { get; set; }

                /// <summary>
                /// <para>The member ID.</para>
                /// <remarks>
                /// <para>This parameter is returned only when you call this operation by using a management account.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>120886317861****</para>
                /// </summary>
                [NameInMap("SLSUserId")]
                [Validation(Required=false)]
                public string SLSUserId { get; set; }

            }

            /// <summary>
            /// <para>The description of the Logstore group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Logstore group of Alibaba Cloud products.</para>
            /// </summary>
            [NameInMap("SLSGroupDescription")]
            [Validation(Required=false)]
            public string SLSGroupDescription { get; set; }

            /// <summary>
            /// <para>The name of the Logstore group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Logstore_test</para>
            /// </summary>
            [NameInMap("SLSGroupName")]
            [Validation(Required=false)]
            public string SLSGroupName { get; set; }

            /// <summary>
            /// <para>The timestamp when the Logstore group was last modified.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652845630000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NotFound.SLSGroup</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66683237-7126-50F8-BBF8-D67ACC919A17</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
