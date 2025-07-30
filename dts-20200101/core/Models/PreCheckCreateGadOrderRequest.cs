// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class PreCheckCreateGadOrderRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>gad-bp1i99e8l7913****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("MasterDatabaseName")]
        [Validation(Required=false)]
        public string MasterDatabaseName { get; set; }

        [NameInMap("MasterEngineArchType")]
        [Validation(Required=false)]
        public string MasterEngineArchType { get; set; }

        [NameInMap("MasterShardAccountName")]
        [Validation(Required=false)]
        public string MasterShardAccountName { get; set; }

        [NameInMap("MasterShardAccountPassword")]
        [Validation(Required=false)]
        public string MasterShardAccountPassword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfntftbiobqyky</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SlaveDatabaseName")]
        [Validation(Required=false)]
        public string SlaveDatabaseName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rm-bp17562h64****</para>
        /// </summary>
        [NameInMap("SlaveDbInstanceId")]
        [Validation(Required=false)]
        public string SlaveDbInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SlaveDbInstanceRegion")]
        [Validation(Required=false)]
        public string SlaveDbInstanceRegion { get; set; }

        [NameInMap("SlaveEngineArchType")]
        [Validation(Required=false)]
        public string SlaveEngineArchType { get; set; }

    }

}
