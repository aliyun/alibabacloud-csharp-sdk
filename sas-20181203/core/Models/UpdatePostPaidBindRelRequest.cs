// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePostPaidBindRelRequest : TeaModel {
        /// <summary>
        /// <para>Enable automatic binding for new assets. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Off</description></item>
        /// <item><description><b>1</b>: On</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoBind")]
        [Validation(Required=false)]
        public int? AutoBind { get; set; }

        /// <summary>
        /// <para>Version to automatically bind when adding new assets. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Basic Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Antivirus Edition    </description></item>
        /// <item><description><b>7</b>: Container Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoBindVersion")]
        [Validation(Required=false)]
        public int? AutoBindVersion { get; set; }

        /// <summary>
        /// <para>Parameters for the binding action.</para>
        /// </summary>
        [NameInMap("BindAction")]
        [Validation(Required=false)]
        public List<UpdatePostPaidBindRelRequestBindAction> BindAction { get; set; }
        public class UpdatePostPaidBindRelRequestBindAction : TeaModel {
            /// <summary>
            /// <para>Whether to bind all. Default is <b>false</b>. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes</description></item>
            /// <item><description><b>false</b>: No</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("BindAll")]
            [Validation(Required=false)]
            public bool? BindAll { get; set; }

            /// <summary>
            /// <para>List of specified server UUIDs.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

            /// <summary>
            /// <para>The Cloud Security Center protection version that needs to be bound. Values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic Edition </description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>6</b>: Antivirus Edition    </description></item>
            /// <item><description><b>7</b>: Container Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("UpdateIfNecessary")]
        [Validation(Required=false)]
        public bool? UpdateIfNecessary { get; set; }

    }

}
