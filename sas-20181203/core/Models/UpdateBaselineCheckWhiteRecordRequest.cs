// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateBaselineCheckWhiteRecordRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListCheckItemWarningSummary~~">ListCheckItemWarningSummary</a> operation to obtain the check item ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The reason for adding the whitelist entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Manually processed.</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The ID of the whitelist record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The list of asset UUIDs for which container names are to be removed from the whitelist.</para>
        /// </summary>
        [NameInMap("RemoveContainerUuids")]
        [Validation(Required=false)]
        public List<string> RemoveContainerUuids { get; set; }

        /// <summary>
        /// <para>The data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: host</description></item>
        /// <item><description><b>agentless</b>: agentless.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the target on which the whitelist takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all_instance</b>: all servers</description></item>
        /// <item><description><b>instance</b>: specific servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all_instance</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
