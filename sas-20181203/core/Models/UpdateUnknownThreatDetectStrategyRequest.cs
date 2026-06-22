// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateUnknownThreatDetectStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days the model learns for after its creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterInit")]
        [Validation(Required=false)]
        public int? DurationDaysAfterInit { get; set; }

        /// <summary>
        /// <para>The number of consecutive days without new processes before the model stops learning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterStop")]
        [Validation(Required=false)]
        public int? DurationDaysAfterStop { get; set; }

        /// <summary>
        /// <para>The ID of the unknown threat detection strategy to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The name of the unknown threat detection strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategy****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The whitelist mode. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>hash</b>: process hash</para>
        /// </description></item>
        /// <item><description><para><b>path</b>: process path</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hash</para>
        /// </summary>
        [NameInMap("StudyMode")]
        [Validation(Required=false)]
        public string StudyMode { get; set; }

    }

}
