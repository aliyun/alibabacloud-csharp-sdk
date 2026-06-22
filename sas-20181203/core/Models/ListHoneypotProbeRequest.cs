// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotProbeRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Minimum value: <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the probe.</para>
        /// 
        /// <b>Example:</b>
        /// <para>probe-test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page during paging.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The probe status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>installed</b>: Installation succeeded.</description></item>
        /// <item><description><b>install_failed</b>: Installation failed.</description></item>
        /// <item><description><b>online</b>: Normal.</description></item>
        /// <item><description><b>offline</b>: Offline.</description></item>
        /// <item><description><b>unnormal</b>: Service exception.</description></item>
        /// <item><description><b>unprobe</b>: Unauthorized.</description></item>
        /// <item><description><b>uninstalling</b>: Uninstalling.</description></item>
        /// <item><description><b>uninstalled</b>: Uninstallation succeeded.</description></item>
        /// <item><description><b>uninstall_failed</b>: Uninstallation failed.</description></item>
        /// <item><description><b>not_exist</b>: Not installed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("ProbeStatus")]
        [Validation(Required=false)]
        public string ProbeStatus { get; set; }

        /// <summary>
        /// <para>The probe type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>host_probe</b>: host probe</description></item>
        /// <item><description><b>vpc_black_hole_probe</b>: VPC blackhole probe.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>host_probe</para>
        /// </summary>
        [NameInMap("ProbeType")]
        [Validation(Required=false)]
        public string ProbeType { get; set; }

    }

}
