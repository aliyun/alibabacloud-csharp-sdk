// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class AlignStoragePrimaryAzoneRequest : TeaModel {
        /// <summary>
        /// <para>The name of the PolarDB-X instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-htri0ori2r****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the storage instance whose primary node zone needs to be aligned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-xdb-m-pxcbjrylg49skcxb17394</para>
        /// </summary>
        [NameInMap("StorageInstanceName")]
        [Validation(Required=false)]
        public string StorageInstanceName { get; set; }

        /// <summary>
        /// <para>The start time of the switch for the storage primary node, in the UTC time format YYYY-MM-DDThh:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-11T17:10:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The switchover mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: immediate switchover</description></item>
        /// <item><description>1: switchover during the O&amp;M window</description></item>
        /// <item><description>2: switchover at a specified time</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

    }

}
