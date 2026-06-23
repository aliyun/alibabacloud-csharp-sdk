// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFileVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>Version details of the file.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileVersionResponseBodyData Data { get; set; }
        public class GetFileVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The change type of this file version, including CREATE, UPDATE, and DELETE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }

            /// <summary>
            /// <para>Description of this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Second version submission</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>UNIX timestamp (in milliseconds) when the file version was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1593881265000</para>
            /// </summary>
            [NameInMap("CommitTime")]
            [Validation(Required=false)]
            public long? CommitTime { get; set; }

            /// <summary>
            /// <para>User ID of the Alibaba Cloud user who generated this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7384234****</para>
            /// </summary>
            [NameInMap("CommitUser")]
            [Validation(Required=false)]
            public string CommitUser { get; set; }

            /// <summary>
            /// <para>The code of the file for this version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHOW TABLES;</para>
            /// </summary>
            [NameInMap("FileContent")]
            [Validation(Required=false)]
            public string FileContent { get; set; }

            /// <summary>
            /// <para>File name used to generate this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods_user_info_d</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>Basic information of the file used to generate this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;fileName&quot;:&quot;ods_user_info_d&quot;,&quot;fileType&quot;:10}</para>
            /// </summary>
            [NameInMap("FilePropertyContent")]
            [Validation(Required=false)]
            public string FilePropertyContent { get; set; }

            /// <summary>
            /// <para>The version of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FileVersion")]
            [Validation(Required=false)]
            public int? FileVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether this file version is the latest version in the current production environment.</para>
            /// <list type="bullet">
            /// <item><description><para>true: It is the latest version.</para>
            /// </description></item>
            /// <item><description><para>false: It is not the latest version.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsCurrentProd")]
            [Validation(Required=false)]
            public bool? IsCurrentProd { get; set; }

            /// <summary>
            /// <para>The scan configuration at the time this file version was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cycleType&quot;:0,&quot;cronExpress&quot;:&quot;00 05 00 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("NodeContent")]
            [Validation(Required=false)]
            public string NodeContent { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling task corresponding to the generation of this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000001</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>Current status of the file version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>COMMITTING (Submitting)</para>
            /// </description></item>
            /// <item><description><para>COMMITTED or CHECK_OK (Submitted)</para>
            /// </description></item>
            /// <item><description><para>PACKAGED (Preparing for publish)</para>
            /// </description></item>
            /// <item><description><para>DEPLOYING (In Publish)</para>
            /// </description></item>
            /// <item><description><para>DEPLOYED (Published)</para>
            /// </description></item>
            /// <item><description><para>CANCELLED (Publish canceled)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMMITTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Function module to which the file belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: NORMAL (Data Development)</para>
            /// </description></item>
            /// <item><description><para>1: MANUAL (one-time task)</para>
            /// </description></item>
            /// <item><description><para>2: MANUAL_BIZ (manual pipeline)</para>
            /// </description></item>
            /// <item><description><para>3: SKIP (Dry-Run scheduling in Data Development)</para>
            /// </description></item>
            /// <item><description><para>10: ADHOCQUERY (Ad Hoc Query)</para>
            /// </description></item>
            /// <item><description><para>30: COMPONENT (widget Management)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("UseType")]
            [Validation(Required=false)]
            public string UseType { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The unique ID of this request. If an error occurs, you can troubleshoot the issue using this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
