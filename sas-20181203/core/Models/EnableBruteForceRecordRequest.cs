// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class EnableBruteForceRecordRequest : TeaModel {
        /// <summary>
        /// <para>The IP address that is specified in the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61.155.XX.XX</para>
        /// </summary>
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        /// <summary>
        /// <para>The traffic direction that is specified in the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound</description></item>
        /// <item><description><b>out</b>: outbound</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Bound")]
        [Validation(Required=false)]
        public string Bound { get; set; }

        /// <summary>
        /// <para>The ID of the policy that you want to enable.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeBruteForceRecords~~">DescribeBruteForceRecords</a> operation to query the IDs of policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>116602XX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22/22</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71046acb-8bff-4c3b-9163-24deb007****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
