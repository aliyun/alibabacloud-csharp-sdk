// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginBaseConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of logon configuration details.</para>
        /// </summary>
        [NameInMap("BaseConfigs")]
        [Validation(Required=false)]
        public List<DescribeLoginBaseConfigsResponseBodyBaseConfigs> BaseConfigs { get; set; }
        public class DescribeLoginBaseConfigsResponseBodyBaseConfigs : TeaModel {
            /// <summary>
            /// <para>The common logon account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582318****</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The end time of the common logon time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>07:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The common logon IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The common logon location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BeiJing</para>
            /// </summary>
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>The remark information displayed for the corresponding configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The start time of the common logon time range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The list of details about the servers on which the rule takes effect.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeLoginBaseConfigsResponseBodyBaseConfigsTargetList> TargetList { get; set; }
            public class DescribeLoginBaseConfigsResponseBodyBaseConfigsTargetList : TeaModel {
                /// <summary>
                /// <para>The UUID of the server or the ID of the server group on which the rule takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0011ea53-738c-4bff-93be-ce6a1cc9****</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The selection mode for the assets on which the rule takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>uuid</b>: added by individual asset.</description></item>
                /// <item><description><b>groupId</b>: added by server group.</description></item>
                /// <item><description><b>global</b>: all assets are selected.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>uuid</para>
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// <para>The total number of servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// <para>The number of servers on which the rule takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("UuidCount")]
            [Validation(Required=false)]
            public int? UuidCount { get; set; }

        }

        /// <summary>
        /// <para>The current page number in the paging query result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of logon configuration entries displayed on each page in the paging query result. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2C2D4B3C-0524-17B1-93D2-DA50119F4E1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of logon configuration entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
