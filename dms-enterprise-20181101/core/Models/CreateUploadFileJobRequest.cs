// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateUploadFileJobRequest : TeaModel {
        /// <summary>
        /// <para>The name of the attachment file.</para>
        /// <remarks>
        /// <para> The file name must end with .txt or .sql. For example, the file name can be test.txt or test.sql.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.txt</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The purpose of the attachment file. Valid values:</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/198073.html">GetUserActiveTenant</a> operation to query the tenant ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3***</para>
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// <para>The URL of the attachment file. The URL must be an HTTP URL or an HTTPS URL.</para>
        /// <remarks>
        /// <para> You can upload the attachment file to an Object Storage Service (OSS) bucket and obtain the URL of the file in the OSS console. For more information, see <a href="https://help.aliyun.com/document_detail/195674.html">Share objects</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://XXX.oss-cn-hangzhou.aliyuncs.com/test.txt">https://XXX.oss-cn-hangzhou.aliyuncs.com/test.txt</a></para>
        /// </summary>
        [NameInMap("UploadURL")]
        [Validation(Required=false)]
        public string UploadURL { get; set; }

    }

}
