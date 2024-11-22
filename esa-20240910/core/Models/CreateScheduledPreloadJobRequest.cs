// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateScheduledPreloadJobRequest : TeaModel {
        /// <summary>
        /// <para>The method to submit URLs to be prefetched.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>textBox</b></description></item>
        /// <item><description><b>oss</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("InsertWay")]
        [Validation(Required=false)]
        public string InsertWay { get; set; }

        /// <summary>
        /// <para>The name of the scheduled prefetch task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The URL of the OSS object that stores the URLs to be prefetched.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7">https://xxxobject.oss-cn-reginon.aliyuncs.com/9d91_xxxxxxxxxxx_158bb6e0f97c477791209bb46bd599f7</a></para>
        /// </summary>
        [NameInMap("OssUrl")]
        [Validation(Required=false)]
        public string OssUrl { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>190007158391808</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The URLs to be prefetched. This parameter is required if you set InsertWay to textBox.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://testurl.com/a.txt">http://testurl.com/a.txt</a>
        /// <a href="http://testurl.com/b.txt">http://testurl.com/b.txt</a></para>
        /// </summary>
        [NameInMap("UrlList")]
        [Validation(Required=false)]
        public string UrlList { get; set; }

    }

}
