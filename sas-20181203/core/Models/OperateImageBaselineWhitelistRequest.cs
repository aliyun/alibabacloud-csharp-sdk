// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateImageBaselineWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The keys of baseline check items.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc.image.checklist.identify.hc_exploit_es_linux.item</para>
        /// </summary>
        [NameInMap("BaselineItemKeyList")]
        [Validation(Required=false)]
        public string BaselineItemKeyList { get; set; }

        /// <summary>
        /// <para>The UUID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5250ebca765dc9eb1a84b790b0e****</para>
        /// </summary>
        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform on the check items. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>add</b>: adds the check items to the whitelist</description></item>
        /// <item><description><b>del</b>: removes the check items from the whitelist</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The types of the assets that you want to scan.</para>
        /// </summary>
        [NameInMap("ScanRange")]
        [Validation(Required=false)]
        public List<string> ScanRange { get; set; }

    }

}
