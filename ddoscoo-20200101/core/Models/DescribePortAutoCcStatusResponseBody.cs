// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortAutoCcStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the configurations of the Intelligent Protection policy.</para>
        /// </summary>
        [NameInMap("PortAutoCcStatus")]
        [Validation(Required=false)]
        public List<DescribePortAutoCcStatusResponseBodyPortAutoCcStatus> PortAutoCcStatus { get; set; }
        public class DescribePortAutoCcStatusResponseBodyPortAutoCcStatus : TeaModel {
            /// <summary>
            /// <para>The mode of the Intelligent Protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b></description></item>
            /// <item><description><b>loose</b></description></item>
            /// <item><description><b>strict</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The status of the Intelligent Protection policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Switch")]
            [Validation(Required=false)]
            public string Switch { get; set; }

            /// <summary>
            /// <para>The protection mode for ports 80 and 443. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b></description></item>
            /// <item><description><b>loose</b></description></item>
            /// <item><description><b>strict</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("WebMode")]
            [Validation(Required=false)]
            public string WebMode { get; set; }

            /// <summary>
            /// <para>The status of the Intelligent Protection policy for ports 80 and 443. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>off</para>
            /// </summary>
            [NameInMap("WebSwitch")]
            [Validation(Required=false)]
            public string WebSwitch { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC3C6403-F248-4125-B2C9-8733ED94EA85</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
