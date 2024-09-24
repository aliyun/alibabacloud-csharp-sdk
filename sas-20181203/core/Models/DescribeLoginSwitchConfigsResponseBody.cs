// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginSwitchConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration item returned.</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeLoginSwitchConfigsResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeLoginSwitchConfigsResponseBodyConfigList : TeaModel {
            /// <summary>
            /// <para>The type of the alert that you enabled or disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>login_common_ip</b>: alerts for unapproved logon IP addresses</description></item>
            /// <item><description><b>login_common_time</b>: alerts for unapproved logon time ranges</description></item>
            /// <item><description><b>login_common_account</b>: alerts for unapproved logon accounts</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_ip</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The status of the Log Service feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The feature is disabled.</description></item>
            /// <item><description><b>1</b>: The feature is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The number of returned configuration items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
