// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateQualityRuleRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the AICCS instance. You can obtain instance ID from the Artificial Intelligence Cloud Call Service console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The keywords.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("KeyWords")]
        [Validation(Required=false)]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// <para>The keyword match type. Valid values:	</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Any keyword appears.</description></item>
        /// <item><description><b>2</b>: All keywords appear.</description></item>
        /// <item><description><b>3</b>: No keyword appears.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public int? MatchType { get; set; }

        /// <summary>
        /// <para>The name of the quality check.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Automated quality check rule</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The tag of the quality check rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>638</para>
        /// </summary>
        [NameInMap("RuleTag")]
        [Validation(Required=false)]
        public int? RuleTag { get; set; }

    }

}
