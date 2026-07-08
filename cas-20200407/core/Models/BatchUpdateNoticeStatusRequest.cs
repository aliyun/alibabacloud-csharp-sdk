// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class BatchUpdateNoticeStatusRequest : TeaModel {
        /// <summary>
        /// <para>The list of primary key identifiers to be synchronized to Certificate Management Service. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>888</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The language type for the request and the received message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The business code of message notification. The value is fixed as ssl.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ssl</para>
        /// </summary>
        [NameInMap("NoticeBiz")]
        [Validation(Required=false)]
        public string NoticeBiz { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable message notification.
        /// \--enable: enables message notification.
        /// \--disable: disables message notification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disable</para>
        /// </summary>
        [NameInMap("NoticeStatus")]
        [Validation(Required=false)]
        public string NoticeStatus { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.98.242.200</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
