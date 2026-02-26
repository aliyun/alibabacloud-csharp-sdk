// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class WebofficePermission : TeaModel {
        /// <summary>
        /// <para>Specifies whether the user has the copy permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Copy")]
        [Validation(Required=false)]
        public bool? Copy { get; set; }

        /// <summary>
        /// <para>Specifies whether the user has the permission to export the file as a PDF file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The user has the permission to export the file as a PDF file. If you set this parameter to true, you must set the Print parameter to true.</description></item>
        /// <item><description>false: The user does not have the permission to export the file as a PDF file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Export")]
        [Validation(Required=false)]
        public bool? Export { get; set; }

        /// <summary>
        /// <para>Specifies whether the user has the permission to view historical versions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("History")]
        [Validation(Required=false)]
        public bool? History { get; set; }

        /// <summary>
        /// <para>Specifies whether the user has the printing permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Print")]
        [Validation(Required=false)]
        public bool? Print { get; set; }

        /// <summary>
        /// <para>Specifies whether the user has read-only access to the file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Readonly")]
        [Validation(Required=false)]
        public bool? Readonly { get; set; }

        /// <summary>
        /// <para>Specifies whether the user has the permission to rename a file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can query the operation information only based a notification sent to Simple Message Queue (SMQ). A rename event is included in the notification.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Rename")]
        [Validation(Required=false)]
        public bool? Rename { get; set; }

    }

}
