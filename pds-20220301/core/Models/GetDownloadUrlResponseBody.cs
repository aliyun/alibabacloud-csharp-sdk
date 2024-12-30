// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>The download URL of a file that is downloaded by using Alibaba Cloud CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data-cdn.aliyunpds.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&Signature=xxx&response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt">https://data-cdn.aliyunpds.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&amp;Signature=xxx&amp;response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt</a></para>
        /// </summary>
        [NameInMap("cdn_url")]
        [Validation(Required=false)]
        public string CdnUrl { get; set; }

        /// <summary>
        /// <para>The hash value of the file content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA4942AA8761213890A5C386F88E6464D2C31CA1</para>
        /// </summary>
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// <para>The name of the algorithm that is used to calculate the hash value of the file content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha1</para>
        /// </summary>
        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        /// <summary>
        /// <para>The hash value calculated by using 64-bit cyclic redundancy check (CRC-64).</para>
        /// 
        /// <b>Example:</b>
        /// <para>5498595269368962671</para>
        /// </summary>
        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        /// <summary>
        /// <para>The time when the download URL expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T15:04:05.999Z07:00</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>The download URL of a file that is downloaded over a virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data-vpc.aliyunpds.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&Signature=xxx&response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt">https://data-vpc.aliyunpds.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&amp;Signature=xxx&amp;response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt</a></para>
        /// </summary>
        [NameInMap("internal_url")]
        [Validation(Required=false)]
        public string InternalUrl { get; set; }

        /// <summary>
        /// <para>The size of the file. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The download URL of a file that is downloaded over the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&Signature=xxx&response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt">https://data.aliyunpds.com/hz22%2F5d79219b0aa9a7c995a94a96993ba3205cd91c5a%2F5d79219bf3261a5d38744da0834ed489b677a27a?Expires=xxxOSSAccessKeyId=xxx&amp;Signature=xxx&amp;response-content-disposition=attachment%3Bfilename%3DtBiZAoJPC2c8b13450eda4292b7f5f8010618e078.txt</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
