// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDagComplementRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("BizBeginTime")]
        [Validation(Required=false)]
        public string BizBeginTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23:00:00</para>
        /// </summary>
        [NameInMap("BizEndTime")]
        [Validation(Required=false)]
        public string BizEndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-21 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizDate")]
        [Validation(Required=false)]
        public string EndBizDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74324,74325</para>
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xm_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{74324:&quot;key1=val1 key2=val&quot;}</para>
        /// </summary>
        [NameInMap("NodeParams")]
        [Validation(Required=false)]
        public string NodeParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public bool? Parallelism { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RootNodeId")]
        [Validation(Required=false)]
        public long? RootNodeId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-20 00:00:00</para>
        /// </summary>
        [NameInMap("StartBizDate")]
        [Validation(Required=false)]
        public string StartBizDate { get; set; }

    }

}
