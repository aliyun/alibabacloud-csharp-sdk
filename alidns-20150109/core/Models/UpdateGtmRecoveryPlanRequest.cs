// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmRecoveryPlanRequest : TeaModel {
        /// <summary>
        /// <para>The list of faulty address pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;hra0or&quot;]</para>
        /// </summary>
        [NameInMap("FaultAddrPool")]
        [Validation(Required=false)]
        public string FaultAddrPool { get; set; }

        /// <summary>
        /// <para>The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the disaster recovery plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the disaster recovery plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RecoveryPlanId")]
        [Validation(Required=false)]
        public long? RecoveryPlanId { get; set; }

        /// <summary>
        /// <para>The remarks about the disaster recovery plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
