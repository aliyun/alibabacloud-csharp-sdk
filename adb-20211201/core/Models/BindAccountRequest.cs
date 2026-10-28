// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class BindAccountRequest : TeaModel {
        /// <summary>
        /// <para>The standard database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_accout</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The ID of the Enterprise Edition, Basic Edition, or Data Lakehouse Edition cluster.
        /// &lt;props=&quot;intl&quot;&gt;The ID of the Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-wz99d9nh532****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud RAM user to bind.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1444832459****</para>
        /// </summary>
        [NameInMap("RamUser")]
        [Validation(Required=false)]
        public string RamUser { get; set; }

        /// <summary>
        /// <para>The list of IDs of the Alibaba Cloud RAM users to bind. Currently, only one RAM user can be bound. If you specify this parameter, the RamUser parameter does not take effect.</para>
        /// </summary>
        [NameInMap("RamUserList")]
        [Validation(Required=false)]
        public List<string> RamUserList { get; set; }

    }

}
