// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class BindAccountShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A standard database account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_accout</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>ID of the cluster. Applies to Enterprise Edition, Basic Edition, or Data Lakehouse Edition clusters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-wz99d9nh532****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>ID of the Alibaba Cloud RAM user to bind.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1444832459****</para>
        /// </summary>
        [NameInMap("RamUser")]
        [Validation(Required=false)]
        public string RamUser { get; set; }

        /// <summary>
        /// <para>List of Alibaba Cloud RAM user IDs to bind. You can bind only one RAM user at a time. If you specify this parameter, the RamUser parameter is ignored.</para>
        /// </summary>
        [NameInMap("RamUserList")]
        [Validation(Required=false)]
        public string RamUserListShrink { get; set; }

    }

}
