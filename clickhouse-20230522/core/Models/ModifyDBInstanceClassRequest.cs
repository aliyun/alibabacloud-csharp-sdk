// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceClassRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NodeScaleMax")]
        [Validation(Required=false)]
        public int? NodeScaleMax { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("NodeScaleMin")]
        [Validation(Required=false)]
        public int? NodeScaleMin { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The maximum capacity for elastic scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public long? ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum capacity for elastic scaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public long? ScaleMin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StorageQuota")]
        [Validation(Required=false)]
        public long? StorageQuota { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
