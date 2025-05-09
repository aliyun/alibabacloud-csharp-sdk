// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GenerateOpsItemRequest : TeaModel {
        /// <summary>
        /// <para>The token that is used to ensure the idempotency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configuration ID of the O\&amp;M item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oic-ae4f******2c682e3</para>
        /// </summary>
        [NameInMap("ConfigurationId")]
        [Validation(Required=false)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// <para>The source system data.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/aliyun/ecs</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The data source system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/aliyun/eventbridge/event</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
