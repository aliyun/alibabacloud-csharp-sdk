// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotTrackingRequest : TeaModel {
        /// <summary>
        /// <para>End time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725413948000</para>
        /// </summary>
        [NameInMap("beg_end")]
        [Validation(Required=false)]
        public long? BegEnd { get; set; }

        /// <summary>
        /// <para>Start time</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725410348000</para>
        /// </summary>
        [NameInMap("beg_start")]
        [Validation(Required=false)]
        public long? BegStart { get; set; }

        /// <summary>
        /// <para>Hot spot type</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alloc</para>
        /// </summary>
        [NameInMap("hot_type")]
        [Validation(Required=false)]
        public string HotType { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2ze5ru5rjurix7f71sxv</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <para>Process PID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657494</para>
        /// </summary>
        [NameInMap("pid")]
        [Validation(Required=false)]
        public long? Pid { get; set; }

        /// <summary>
        /// <para>Query table name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prof_on</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

    }

}
