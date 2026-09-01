// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateUnknownThreatDetectStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days after the model is initially created before learning stops.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterInit")]
        [Validation(Required=false)]
        public int? DurationDaysAfterInit { get; set; }

        /// <summary>
        /// <para>The number of days after which the model ends if no new processes are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DurationDaysAfterStop")]
        [Validation(Required=false)]
        public int? DurationDaysAfterStop { get; set; }

        /// <summary>
        /// <para>The ID of the policy to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategy****</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The whitelist mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hash</b>: process hash</description></item>
        /// <item><description><b>path</b>: process path</description></item>
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
