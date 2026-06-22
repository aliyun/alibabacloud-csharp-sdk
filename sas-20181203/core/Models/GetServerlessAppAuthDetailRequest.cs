// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServerlessAppAuthDetailRequest : TeaModel {
        /// <summary>
        /// <para>The SAE application ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListMachineApps~~">ListMachineApps</a> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3de9f2ac-f***769226df</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The region ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AppRegionId")]
        [Validation(Required=false)]
        public string AppRegionId { get; set; }

        /// <summary>
        /// <para>The server type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RunD</b></description></item>
        /// <item><description><b>ECI</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RunD</para>
        /// </summary>
        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        /// <summary>
        /// <para>The cloud service to which the application belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASK</b></description></item>
        /// <item><description><b>SAE</b></description></item>
        /// <item><description><b>ACS</b>.</description></item>
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
