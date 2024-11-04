// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryRecordFileDownloadUrlRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the call record. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view <b>Call Record ID</b> on the <b>Call Record Query</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcedf1234</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The call initiation time in the call record. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a>. View <b>Call Initiated At</b> on the <b>Call Record Query</b> page, or view the call_time field in the Call Detail Record (CDR) receipt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-05 12:00:00</para>
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public string CallTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <remarks>
        /// <para> This parameter is required when <b>ProductType</b> is left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FC123456</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AXB_170</b>.</description></item>
        /// <item><description><b>AXN_170</b>.</description></item>
        /// <item><description><b>AXN_95</b>.</description></item>
        /// <item><description><b>AXN_EXTENSION_REUSE</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is applicable to the original key accounts of Alibaba Cloud. This parameter can be ignored for Alibaba Cloud users.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required when <b>PoolKey</b> is left empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AXB_170</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
