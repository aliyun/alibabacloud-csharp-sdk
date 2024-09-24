// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateAttestorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the KMS key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2e81355b-f8e7-4090-8082-a8f8124a****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The region ID of the Key Management Service (KMS) key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("KeyRegionId")]
        [Validation(Required=false)]
        public string KeyRegionId { get; set; }

        /// <summary>
        /// <para>The version ID of the KMS key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8d7c9c91-57ce-4cf4-a959-1e700e13****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

        /// <summary>
        /// <para>The name of the witness.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attestor-auto-ad5316</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>attestor</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
