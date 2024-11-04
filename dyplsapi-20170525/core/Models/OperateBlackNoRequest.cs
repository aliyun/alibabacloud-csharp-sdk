// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class OperateBlackNoRequest : TeaModel {
        /// <summary>
        /// <para>The phone number to be added to or deleted from the blacklist.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150****0000</para>
        /// </summary>
        [NameInMap("BlackNo")]
        [Validation(Required=false)]
        public string BlackNo { get; set; }

        /// <summary>
        /// <para>The type of the operation on the phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AddBlack</b>: adds the phone number to the blacklist.</description></item>
        /// <item><description><b>DeleteBlack</b>: deletes the phone number from the blacklist.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddBlack</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC123456****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("Tips")]
        [Validation(Required=false)]
        public string Tips { get; set; }

    }

}
