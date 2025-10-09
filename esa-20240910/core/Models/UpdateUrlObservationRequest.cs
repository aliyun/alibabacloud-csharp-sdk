// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateUrlObservationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the configuration. You can call the <a href="~~ListUrlObservations~~">ListUrlObservations</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>SDK integration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>automatic</b> (Recommended)</description></item>
        /// <item><description><b>manual</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manual</para>
        /// </summary>
        [NameInMap("SdkType")]
        [Validation(Required=false)]
        public string SdkType { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="~~ListSites~~">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
