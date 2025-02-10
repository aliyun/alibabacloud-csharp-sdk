// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDomainRecordRequest : TeaModel {
        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The resolution line. Default value: <b>default</b>.</para>
        /// <para>For more information, see</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29807.htm">DNS resolution lines</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Line")]
        [Validation(Required=false)]
        public string Line { get; set; }

        /// <summary>
        /// <para>The priority of the mail exchanger (MX) record. Valid values: <c>1 to 50</c>.</para>
        /// <para>This parameter is required if the type of the DNS record is MX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <para>The hostname.</para>
        /// <para>For example, if you want to resolve @.example.com, you must set RR to an at sign (@) instead of leaving it empty.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>www</para>
        /// </summary>
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        /// <summary>
        /// <para>The ID of the DNS record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9999985</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The time to live (TTL) period of the Alibaba Cloud DNS (DNS) record. Default value: 600. Unit: seconds.</para>
        /// <para>For more information, see</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29806.htm">TTL definition</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("TTL")]
        [Validation(Required=false)]
        public long? TTL { get; set; }

        /// <summary>
        /// <para>The type of the DNS record. For more information, see</para>
        /// <para><a href="https://www.alibabacloud.com/help/zh/doc-detail/29805.htm">DNS record types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.0</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The record value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.2.254</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
