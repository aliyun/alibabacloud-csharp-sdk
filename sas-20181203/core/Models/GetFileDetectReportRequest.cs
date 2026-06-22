// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectReportRequest : TeaModel {
        /// <summary>
        /// <para>The event ID that corresponds to the file to be detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The field that you want to query. You can enter multiple fields and separate them with commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ThreatTypes</b>: the type of the threat intelligence event</para>
        /// </description></item>
        /// <item><description><para><b>Intelligences</b>: the threat intelligence event</para>
        /// </description></item>
        /// <item><description><para><b>ThreatLevel</b>: the level of the threat intelligence event</para>
        /// </description></item>
        /// <item><description><para><b>Basic</b>: the basic information about the report (the scan result)</para>
        /// </description></item>
        /// <item><description><para><b>Sandbox</b>: the cloud sandbox check report</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Basic,,ThreatTypes,Intelligences,Sandbox</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The hash value of the file to be detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b63917332950e5d219d0737ffe31****</para>
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>machine</b>: host alerts</para>
        /// </description></item>
        /// <item><description><para><b>object_scan</b>: file detection alerts</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>object_scan</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
