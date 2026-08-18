// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetFileVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The version details of the file.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileVersionResponseBodyData Data { get; set; }
        public class GetFileVersionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The change type of this file version. Valid values: CREATE, UPDATE, and DELETE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("ChangeType")]
            [Validation(Required=false)]
            public string ChangeType { get; set; }

            /// <summary>
            /// <para>The description of this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Second version submission</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The timestamp when the file version was generated, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1593881265000</para>
            /// </summary>
            [NameInMap("CommitTime")]
            [Validation(Required=false)]
            public long? CommitTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud user ID that generated this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7384234****</para>
            /// </summary>
            [NameInMap("CommitUser")]
            [Validation(Required=false)]
            public string CommitUser { get; set; }

            /// <summary>
            /// <para>The file code that generated this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHOW TABLES;</para>
            /// </summary>
            [NameInMap("FileContent")]
            [Validation(Required=false)]
            public string FileContent { get; set; }

            /// <summary>
            /// <para>The name of the file that generated this file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ods_user_info_d</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The basic file information when this file version was generated.</para>
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
            /// <para>Indicates whether this file version is the latest version in the production environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The version is the latest version.</description></item>
            /// <item><description>false: The version is not the latest version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsCurrentProd")]
            [Validation(Required=false)]
            public bool? IsCurrentProd { get; set; }

            /// <summary>
            /// <para>The scheduling configuration when this file version was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;cycleType&quot;:0,&quot;cronExpress&quot;:&quot;00 05 00 * * ?&quot;}</para>
            /// </summary>
            [NameInMap("NodeContent")]
            [Validation(Required=false)]
            public string NodeContent { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling node associated with the file version when it was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000001</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The current status of the file version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>COMMITTING: The version is being committed.</description></item>
            /// <item><description>COMMITTED or CHECK_OK: The version has been committed.</description></item>
            /// <item><description>PACKAGED: The version is ready for deployment.</description></item>
            /// <item><description>DEPLOYING: The version is being deployed.</description></item>
            /// <item><description>DEPLOYED: The version has been deployed.</description></item>
            /// <item><description>CANCELLED: The deployment has been canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMMITTED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The functional module to which the file belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: NORMAL (DataStudio)</description></item>
            /// <item><description>1: MANUAL (manual node)</description></item>
            /// <item><description>2: MANUAL_BIZ (manual workflow)</description></item>
            /// <item><description>3: SKIP (dry-run scheduling in DataStudio)</description></item>
            /// <item><description>10: ADHOCQUERY (ad hoc query)</description></item>
            /// <item><description>30: COMPONENT (component management)</description></item>
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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
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
