// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class MedicalKnowledgeInfo : TeaModel {
        /// <summary>
        /// <para>The structured text composed of the entity name and its properties.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Entity: Amoxicillin capsules</para>
        /// <list type="bullet">
        /// <item><description>Property[Exact active ingredient]: Amoxicillin</description></item>
        /// <item><description>Property[Manufactured dosage form]: Oral capsule</description></item>
        /// </list>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The source link of the entity property content.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://p.example.cn/0387f345/index?struct_id=VdB%2BLV7w7lHHEp">https://p.example.cn/0387f345/index?struct_id=VdB%2BLV7w7lHHEp</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
