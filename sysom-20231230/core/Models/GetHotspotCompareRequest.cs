// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetHotspotCompareRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>The end time 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725415774000</para>
        /// </summary>
        [NameInMap("beg1_end")]
        [Validation(Required=false)]
        public long? Beg1End { get; set; }

        /// <summary>
        /// <para>The start time 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725415474000</para>
        /// </summary>
        [NameInMap("beg1_start")]
        [Validation(Required=false)]
        public long? Beg1Start { get; set; }

        /// <summary>
        /// <para>The end time 2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725415774000</para>
        /// </summary>
        [NameInMap("beg2_end")]
        [Validation(Required=false)]
        public long? Beg2End { get; set; }

        /// <summary>
        /// <para>The start time 2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1725415474000</para>
        /// </summary>
        [NameInMap("beg2_start")]
        [Validation(Required=false)]
        public long? Beg2Start { get; set; }

        /// <summary>
        /// <para>The hot spot type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alloc</para>
        /// </summary>
        [NameInMap("hot_type")]
        [Validation(Required=false)]
        public string HotType { get; set; }

        /// <summary>
        /// <para>The instance 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zei55fwj8nnu31h3z46&quot;</para>
        /// </summary>
        [NameInMap("instance1")]
        [Validation(Required=false)]
        public string Instance1 { get; set; }

        /// <summary>
        /// <para>The instance 2.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("instance2")]
        [Validation(Required=false)]
        public string Instance2 { get; set; }

        /// <summary>
        /// <para>The process of instance 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("pid1")]
        [Validation(Required=false)]
        public long? Pid1 { get; set; }

        /// <summary>
        /// <para>The process of instance 2.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zei55fwj8nnu31h3z46</para>
        /// </summary>
        [NameInMap("pid2")]
        [Validation(Required=false)]
        public long? Pid2 { get; set; }

        /// <summary>
        /// <para>The name of the table to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prof_on</para>
        /// </summary>
        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
