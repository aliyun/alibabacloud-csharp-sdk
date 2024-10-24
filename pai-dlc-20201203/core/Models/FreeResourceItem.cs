// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class FreeResourceItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AvailableNumber")]
        [Validation(Required=false)]
        public long? AvailableNumber { get; set; }

        [NameInMap("ClusterID")]
        [Validation(Required=false)]
        public string ClusterID { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>freeres-whateversth</para>
        /// </summary>
        [NameInMap("FreeResourceId")]
        [Validation(Required=false)]
        public string FreeResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-18T12:52:15Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-18T12:52:15Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>inner</para>
        /// </summary>
        [NameInMap("RegionID")]
        [Validation(Required=false)]
        public string RegionID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cpu</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
