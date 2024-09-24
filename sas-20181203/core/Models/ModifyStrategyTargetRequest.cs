// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyStrategyTargetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;strategyId&quot;:8070645}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Target&quot;:&quot;9273980&quot;,&quot;BindUuidCount&quot;:5320,&quot;TargetType&quot;:&quot;groupId&quot;,&quot;Flag&quot;:&quot;del&quot;},{&quot;Target&quot;:&quot;9677606&quot;,&quot;TargetType&quot;:&quot;groupId&quot;,&quot;Flag&quot;:&quot;del&quot;},{&quot;Target&quot;:&quot;10121607&quot;,&quot;BindUuidCount&quot;:7,&quot;TargetType&quot;:&quot;groupId&quot;,&quot;Flag&quot;:&quot;add&quot;},{&quot;Target&quot;:&quot;10670708&quot;,&quot;BindUuidCount&quot;:2,&quot;TargetType&quot;:&quot;groupId&quot;,&quot;Flag&quot;:&quot;del&quot;},{&quot;Target&quot;:&quot;11246338&quot;,&quot;BindUuidCount&quot;:6,&quot;TargetType&quot;:&quot;groupId&quot;,&quot;Flag&quot;:&quot;del&quot;},{&quot;Target&quot;:&quot;11291161&quot;,&quot;BindUuidCount&quot;:13,&quot;TargetType&quot;:&quot;groupId&quot;,&quot;Flag&quot;:&quot;del&quot;}]</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc_strategy</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
