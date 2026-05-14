// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkDescribeRecordFileUrlRequest : TeaModel {
        /// <summary>
        /// <para>０表示试听，１为下载，默认为1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public long? Download { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8004970</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>通话记录唯一标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uniq_1-162046xxxx.12</para>
        /// </summary>
        [NameInMap("MainUniqueId")]
        [Validation(Required=false)]
        public string MainUniqueId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>不传递获取mp3格式录音，传递时获取wav格式录音。1：双轨录音客户侧，2：双轨录音座席侧，3：两侧合成录音</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecordSide")]
        [Validation(Required=false)]
        public long? RecordSide { get; set; }

        /// <summary>
        /// <para>录音类型。 &quot;record&quot;: 通话录音，&quot;voicemail&quot;: 留言。默认值为 &quot;record&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>record</para>
        /// </summary>
        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>获取录音地址超时时长，单位为秒，默认为一小时，范围在一到二十四小时。</para>
        /// 
        /// <b>Example:</b>
        /// <para>67</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
