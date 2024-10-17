// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateUploadOSSFileJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the file.</para>
        /// <remarks>
        /// <para>The file name must end with .txt or .sql. For example, the file name can be text.txt.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.sql</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The purpose of the file upload task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>datacorrect</b>: The file is uploaded to change data.</description></item>
        /// <item><description><b>order_info_attachment</b>: The file is uploaded as an attachment in a ticket.</description></item>
        /// <item><description><b>big-file</b>: The file is uploaded to import multiple data records at a time.</description></item>
        /// <item><description><b>sqlreview</b>: The file is uploaded for SQL review.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>datacorrect</para>
        /// </summary>
        [NameInMap("FileSource")]
        [Validation(Required=false)]
        public string FileSource { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <remarks>
        /// <para>To view the ID of the tenant, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see the &quot;View information about the current tenant&quot; section of the <a href="https://help.aliyun.com/document_detail/181330.html">Manage DMS tenants</a> topic.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The information about the OSS file to be uploaded.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UploadTarget")]
        [Validation(Required=false)]
        public CreateUploadOSSFileJobRequestUploadTarget UploadTarget { get; set; }
        public class CreateUploadOSSFileJobRequestUploadTarget : TeaModel {
            /// <summary>
            /// <para>The name of the OSS bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_bucket</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The endpoint of the OSS bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://oss-cn-hangzhou.aliyuncs.com">http://oss-cn-hangzhou.aliyuncs.com</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the OSS object.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.sql</para>
            /// </summary>
            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

        }

    }

}
