// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateVirusScanOnceTaskRequest : TeaModel {
        /// <summary>
        /// <para>The information about the scan path that is required for a custom scan.</para>
        /// </summary>
        [NameInMap("ScanPath")]
        [Validation(Required=false)]
        public List<string> ScanPath { get; set; }

        /// <summary>
        /// <para>The type of the virus scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>system</b>: system scan.</description></item>
        /// <item><description><b>user</b>: custom scan.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("ScanType")]
        [Validation(Required=false)]
        public string ScanType { get; set; }

        /// <summary>
        /// <para>The key that stores the asset information.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~GetAssetSelectionConfig~~">GetAssetSelectionConfig</a> operation to obtain the key value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>845de1ec-4b08-42e1-b564-31321e48xxxx</para>
        /// </summary>
        [NameInMap("SelectionKey")]
        [Validation(Required=false)]
        public string SelectionKey { get; set; }

    }

}
