// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServerlessAuthSummaryRequest : TeaModel {
        /// <summary>
        /// <para>Application region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AppRegionId")]
        [Validation(Required=false)]
        public string AppRegionId { get; set; }

        /// <summary>
        /// <para>Server type: </para>
        /// <list type="bullet">
        /// <item><description><b>RunD</b></description></item>
        /// <item><description><b>ECI</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunD</para>
        /// </summary>
        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        /// <summary>
        /// <para>Cloud product: </para>
        /// <list type="bullet">
        /// <item><description><b>ASK</b></description></item>
        /// <item><description><b>SAE</b></description></item>
        /// <item><description><b>ACS</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SAE</para>
        /// </summary>
        [NameInMap("VendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
