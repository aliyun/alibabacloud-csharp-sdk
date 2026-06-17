// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EnableDBClusterServerlessRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-28T14:30:00Z</para>
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-28T14:00:00Z</para>
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The maximum number of steady-state AP read-only nodes. Valid values: 0 to 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMax")]
        [Validation(Required=false)]
        public string ScaleApRoNumMax { get; set; }

        /// <summary>
        /// <para>The minimum number of steady-state AP read-only nodes. Valid values: 0 to 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleApRoNumMin")]
        [Validation(Required=false)]
        public string ScaleApRoNumMin { get; set; }

        /// <summary>
        /// <para>The maximum scaling limit per node. Valid values: 0 PCU to 16 PCU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum scaling limit per node. Valid values: 0 PCU to 16 PCU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// <para>The maximum number of read-only nodes for scaling. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ScaleRoNumMax")]
        [Validation(Required=false)]
        public string ScaleRoNumMax { get; set; }

        /// <summary>
        /// <para>The minimum number of read-only nodes for scaling. Valid values: 0 to 15.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

    }

}
