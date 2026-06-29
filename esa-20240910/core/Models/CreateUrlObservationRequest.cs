// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateUrlObservationRequest : TeaModel {
        /// <summary>
        /// <para>The SDK integration method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>automatic</b>: automatic integration.</description></item>
        /// <item><description><b>manual</b>: manual integration.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>automatic</para>
        /// </summary>
        [NameInMap("SdkType")]
        [Validation(Required=false)]
        public string SdkType { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="~~ListSites~~">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456******</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The URL of the web page to monitor. If the site name is example.com, set Url to example.com/test or site DNS record name/path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com/test</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
