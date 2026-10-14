// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ProcessItem : TeaModel {
        /// <summary>
        /// <para>The bundle identity (Bundle ID) of the application to which the process belongs. The example value com.apple.Terminal is the Bundle ID of the macOS terminal application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.apple.Terminal</para>
        /// </summary>
        [NameInMap("BundleId")]
        [Validation(Required=false)]
        public string BundleId { get; set; }

        /// <summary>
        /// <para>The operating system type of the user terminal device to which the process belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>windows: Windows operating system</description></item>
        /// <item><description>macOS: macOS operating system</description></item>
        /// <item><description>linux: Linux operating system</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>macOS</para>
        /// </summary>
        [NameInMap("DevType")]
        [Validation(Required=false)]
        public string DevType { get; set; }

        /// <summary>
        /// <para>The process folder path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/System/Applications/Utilities/Terminal.app/Contents/MacOS</para>
        /// </summary>
        [NameInMap("Directory")]
        [Validation(Required=false)]
        public string Directory { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminal</para>
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public string Process { get; set; }

    }

}
