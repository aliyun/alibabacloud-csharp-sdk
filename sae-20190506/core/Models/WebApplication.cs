// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebApplication : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sae-app</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The time when the application was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-11 15:54:49</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my sae app</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The public URL for accessing the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://****.cn-hangzhou.sae.run</para>
        /// </summary>
        [NameInMap("InternetURL")]
        [Validation(Required=false)]
        public string InternetURL { get; set; }

        /// <summary>
        /// <para>The internal URL for accessing the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://****.cn-hangzhou-vpc.sae.run</para>
        /// </summary>
        [NameInMap("IntranetURL")]
        [Validation(Required=false)]
        public string IntranetURL { get; set; }

        /// <summary>
        /// <para>The time when the application was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-07-11 20:12:58</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the namespace to which the application belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The configurations of the revision version.</para>
        /// </summary>
        [NameInMap("RevisionConfig")]
        [Validation(Required=false)]
        public RevisionConfig RevisionConfig { get; set; }

        /// <summary>
        /// <para>The Virtual Private Cloud (VPC) ID of the application namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze0i263cnn311nvj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The scaling configurations of the application.</para>
        /// </summary>
        [NameInMap("WebScalingConfig")]
        [Validation(Required=false)]
        public WebScalingConfig WebScalingConfig { get; set; }

        /// <summary>
        /// <para>The traffic configurations of the application.</para>
        /// </summary>
        [NameInMap("WebTrafficConfig")]
        [Validation(Required=false)]
        public WebTrafficConfig WebTrafficConfig { get; set; }

    }

}
