// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInstalledSoftwareResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DDCA0E7B-03E7-430D-810C-0D508539****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The installed software.</para>
        /// </summary>
        [NameInMap("SoftwareList")]
        [Validation(Required=false)]
        public ListInstalledSoftwareResponseBodySoftwareList SoftwareList { get; set; }
        public class ListInstalledSoftwareResponseBodySoftwareList : TeaModel {
            [NameInMap("SoftwareList")]
            [Validation(Required=false)]
            public List<ListInstalledSoftwareResponseBodySoftwareListSoftwareList> SoftwareList { get; set; }
            public class ListInstalledSoftwareResponseBodySoftwareListSoftwareList : TeaModel {
                /// <summary>
                /// <para>The software ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MPICH_3.2</para>
                /// </summary>
                [NameInMap("SoftwareId")]
                [Validation(Required=false)]
                public string SoftwareId { get; set; }

                /// <summary>
                /// <para>The name of the software.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mpich</para>
                /// </summary>
                [NameInMap("SoftwareName")]
                [Validation(Required=false)]
                public string SoftwareName { get; set; }

                /// <summary>
                /// <para>The status of the software. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Installing: The software is being installed.</description></item>
                /// <item><description>Installed: The software is installed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Installing</para>
                /// </summary>
                [NameInMap("SoftwareStatus")]
                [Validation(Required=false)]
                public string SoftwareStatus { get; set; }

                /// <summary>
                /// <para>The version of the software.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.2</para>
                /// </summary>
                [NameInMap("SoftwareVersion")]
                [Validation(Required=false)]
                public string SoftwareVersion { get; set; }

            }

        }

    }

}
