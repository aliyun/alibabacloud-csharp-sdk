// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetSecretAsrDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the call record.</para>
        /// <para>You can log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view <b>Call Record ID</b> on the <b>Call Record Query</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>225625****</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        /// <summary>
        /// <para>The call initiation time in the call record.</para>
        /// <para>You can log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a>. View <b>Call Initiated At</b> on the <b>Call Record Query</b> page, or view the call_time field in the Call Detail Record (CDR) receipt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-05 12:00:00</para>
        /// </summary>
        [NameInMap("CallTime")]
        [Validation(Required=false)]
        public string CallTime { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool.</para>
        /// <para>You can log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2267****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

    }

}
